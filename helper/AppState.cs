using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazerMovies.helper
{
    public class AppState
    {
        public event Action OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();
        public string CurrentPage { get; private set; }
        public void SetCurrentPage(string url)
        {
            CurrentPage = url;
            NotifyStateChanged();
        }
    }
 
}
