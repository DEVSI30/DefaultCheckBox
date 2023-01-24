using System.Windows.Forms;

namespace DefaultCheckBox.Observer.impl
{
    public class StateTxtBoxObserver : StateObserver
    {
        private StateDefaultImpl _state;
        private System.Windows.Forms.TextBox _txtState;

        public StateTxtBoxObserver(StateDefaultImpl state, TextBox txtState)
        {
            _state = state;
            _state.registerObserver(this);
            _txtState = txtState;
            update();
        }

        public void update()
        {
            string stateText = "";
            stateText += "ChkBoxDefault   : " + _state.ChkBoxDefault + "\r\n";
            stateText += "-------------------------------------------------------"+ "\r\n";
            stateText += "Value           : " + _state.Value + "\r\n";
            stateText += "ChkBox2Checked  : " + _state.ChkBox2Checked + "\r\n";
            stateText += "ChkBox3Checked  : " + _state.ChkBox3Checked + "\r\n";
            stateText += "-------------------------------------------------------"+ "\r\n";
            stateText += "ValueBackup     : " + _state.ValueBackup + "\r\n";
            stateText += "ChkBox2Backup   : " + _state.ChkBox2Backup + "\r\n";
            stateText += "ChkBox3Backup   : " + _state.ChkBox3Backup + "\r\n";
            stateText += "-------------------------------------------------------"+ "\r\n";
            stateText += "DefaultValue    : " + _state.GetDefaultValue()+ "\r\n";
            stateText += "Default ChkBox2 : " + _state.GetDefaultCheckBox2Checked() + "\r\n";
            stateText += "Default ChkBox3 : " + _state.GetDefaultCheckBox3Checked() + "\r\n";
            _txtState.Text = stateText;
        }
    }
}