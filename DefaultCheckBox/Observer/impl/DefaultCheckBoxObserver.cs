using System;

namespace DefaultCheckBox.Observer.impl
{
    public class DefaultCheckBoxObserver : StateObserver
    {
        private StateDefaultImpl _state;
        private System.Windows.Forms.CheckBox _checkBox;

        public DefaultCheckBoxObserver(StateDefaultImpl state, System.Windows.Forms.CheckBox checkBox)
        {
            _state = state;
            _state.registerObserver(this);
            _checkBox = checkBox;
            _checkBox.CheckedChanged += new EventHandler(CheckedChanged);
        }

        public void update()
        {
            _checkBox.Checked = _state.ChkBoxDefault;
        }
        
        private void CheckedChanged(Object sender, EventArgs e) {
            _state.ToggleDefaultCheckBox(_checkBox.Checked);
        }
    }
}