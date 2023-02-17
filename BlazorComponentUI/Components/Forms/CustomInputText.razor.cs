using Microsoft.AspNetCore.Components;

namespace BlazorComponentUI.Components.Forms
{
    public partial class CustomInputText<T> : ComponentBase
    {
        [Parameter] public T? Value { get; set; }

        [Parameter] public string LabelText { get; set; }

        [Parameter] public string Name { get; set; }

        [Parameter] public string? Id { get; set; }

        private T _value;

        public CustomInputText()
        {

        }

        protected async Task OnFieldValueChanged(ChangeEventArgs e)
        {
            _value = (T)e.Value;
        }
    }
}
