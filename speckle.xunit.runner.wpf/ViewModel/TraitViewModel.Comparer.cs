using System;
using System.Collections.Generic;

namespace Xunit.Runner.Wpf.ViewModel
{
    public partial class TraitViewModel
    {
        private static readonly TraitViewModelComparer _comparer = new TraitViewModelComparer();

        internal static IComparer<TraitViewModel> Comparer => _comparer;
        internal static IEqualityComparer<TraitViewModel> EqualityComparer => _comparer;

        private class TraitViewModelComparer : IEqualityComparer<TraitViewModel>, IComparer<TraitViewModel>
        {
            public int Compare(TraitViewModel x, TraitViewModel y) => StringComparer.Ordinal.Compare(x.FullText, y.FullText);
            public bool Equals(TraitViewModel x, TraitViewModel y) => StringComparer.Ordinal.Equals(x.FullText, y.FullText);
            public int GetHashCode(TraitViewModel obj) => obj.FullText.GetHashCode();
        }
    }
}
