using System.Collections.Generic;
using System.ComponentModel;

namespace ASM.Lib.Types {
    internal class SortableBindingList<T> : BindingList<T> {
        private bool isSorted;
        private ListSortDirection sortDirection = ListSortDirection.Ascending;
        private PropertyDescriptor sortProperty;

        protected override bool SupportsSortingCore => true;
        protected override bool IsSortedCore => isSorted;
        protected override PropertyDescriptor SortPropertyCore => sortProperty;
        protected override ListSortDirection SortDirectionCore => sortDirection;

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction) {
            if (Items is List<T> itemsList) {
                itemsList.Sort((x, y) => {
                    object xValue = prop.GetValue(x);
                    object yValue = prop.GetValue(y);

                    return direction == ListSortDirection.Ascending
                        ? Comparer<object>.Default.Compare(xValue, yValue)
                        : Comparer<object>.Default.Compare(yValue, xValue);
                });

                isSorted = true;
                sortDirection = direction;
                sortProperty = prop;
                ResetBindings();
            }
        }

        protected override void RemoveSortCore() {
            isSorted = false;
        }
    }
}
