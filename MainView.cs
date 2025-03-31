using ASM.Components;
using ASM.Controllers;
using ASM.Lib;
using ASM.Lib.Constants;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ASM {
    internal partial class MainView : Form {
        private bool isSidebarCollapsed;
        private CustomButton activeButton;
        private MainController controller;

        public MainView() {
            InitializeComponent();
            Init();
        }

        private void Init() {
            isSidebarCollapsed = false;
            controller = new MainController();

            Database.LoadFile();
            Localizer.Init(this);

            LoadPage(btnCustomers);
        }

        private void SetActiveButton(CustomButton button) {
            if (activeButton == button) {
                return;
            }

            if (activeButton != null && activeButton != button) {
                activeButton.BackColor = ColorConstants.SECONDARY;
                activeButton.FlatAppearance.MouseOverBackColor = ColorConstants.SECONDARY_HOVER;
                activeButton.Font = new Font(activeButton.Font, FontStyle.Regular);
            }

            button.BackColor = ColorConstants.PRIMARY;
            button.FlatAppearance.MouseOverBackColor = ColorConstants.PRIMARY_HOVER;
            button.Font = new Font(button.Font, FontStyle.Bold);
            activeButton = button;

            lblPageTitle.Tag = button.Tag;
            Localizer.ApplyLocalization(lblPageTitle);
        }

        private void LoadPage(CustomButton button) {
            string key = button.Tag.ToString();
            UserControl page = controller.GetPage(key);
            page.Dock = DockStyle.Fill;

            if (page == null || GetCurrentPage()?.GetType() == page.GetType()) {
                return;
            }

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(page);
            Localizer.ApplyLocalizations(pnlContainer);
            SetActiveButton(button);
        }

        private UserControl GetCurrentPage() {
            return pnlContainer.Controls.Count > 0 ? pnlContainer.Controls[0] as UserControl : null;
        }

        private void ToggleSidebar(object sender, EventArgs e) {
            isSidebarCollapsed = !isSidebarCollapsed;
            pnlLayout.Panel1MinSize = isSidebarCollapsed ? AppConstants.SIDEBAR_COLLAPSED_WIDTH : AppConstants.SIDEBAR_WIDTH;
            pnlLayout.SplitterDistance = pnlLayout.Panel1MinSize;

            foreach (var button in pnlSidebar.Controls.OfType<CustomButton>()) {
                button.Text = isSidebarCollapsed ? "" : Localizer.GetResource(button.Tag.ToString());
                button.ImageAlign = isSidebarCollapsed ? ContentAlignment.MiddleCenter : ContentAlignment.MiddleLeft;
            }
        }

        private void SidebarBtnsClick(object sender, EventArgs e) {
            LoadPage((CustomButton)sender);
        }

        private void Exit(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
