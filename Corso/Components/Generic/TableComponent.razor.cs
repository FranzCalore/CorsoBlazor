using Microsoft.AspNetCore.Components;

namespace Corso.Components.Generic
{
    public partial class TableComponent<T>
    {
        private List<T> _items = new();

        private Dictionary<string, Func<T, object>> _columnConfig = new();

        private string _testoBottone = "Azione";

        private EventCallback<T> _onAzioneClick;

        [Parameter]
        public List<T> Items
        {
            get => _items;
            set
            {
                _items = value;
                if (_items.Any())
                    AutoConfigureColumns();
            }
        }

        [Parameter]
        public string TestoBottone
        {
            get => _testoBottone;
            set => _testoBottone = value;
        }

        [Parameter]
        public EventCallback<T> OnAzioneClick
        {
            get => _onAzioneClick;
            set => _onAzioneClick = value;
        }

        [Parameter]
        public Dictionary<string, Func<T, object>>? CustomColumns { get; set; }

        protected override void OnParametersSet()
        {
            if (Items.Any() && _columnConfig.Count == 0)
                AutoConfigureColumns();
        }

        private void AutoConfigureColumns()
        {
            _columnConfig = new Dictionary<string, Func<T, object>>();

            var properties = typeof(T).GetProperties();
            foreach (var prop in properties)
            {
                _columnConfig[prop.Name] = item => prop.GetValue(item) ?? string.Empty;
            }

            if (CustomColumns != null)
            {
                foreach (var col in CustomColumns)
                {
                    _columnConfig[col.Key] = col.Value;
                }
            }
        }

        public List<string> GetColumnNames() => _columnConfig.Keys.ToList();

    }
}
