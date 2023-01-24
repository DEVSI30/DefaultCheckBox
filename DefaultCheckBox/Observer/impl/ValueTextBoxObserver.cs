using System;

namespace DefaultCheckBox.Observer.impl
{
    public class ValueTextBoxObserver : StateObserver
    {
        private StateDefaultImpl _state;
        private System.Windows.Forms.TextBox _textBox;

        public ValueTextBoxObserver(StateDefaultImpl state, System.Windows.Forms.TextBox textBox)
        {
            _state = state;
            _state.registerObserver(this);
            _textBox = textBox;
            _textBox.TextChanged += new EventHandler(textChanged);
        }

        public void update()
        {
            _textBox.Text = _state.Value.ToString();
        }

        private void textChanged(object sender, EventArgs args)
        {
            bool tryParse = decimal.TryParse(_textBox.Text, out decimal value);
            if (tryParse)
            {
                _state.Value = value;
            }
        }
    }
}