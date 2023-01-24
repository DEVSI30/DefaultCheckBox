using System.Collections.Generic;

namespace DefaultCheckBox.Observer.impl
{
    public class StateDefaultImpl : StateDefault
    {
        private List<StateObserver> _observers;

        // 기본값
        private const decimal DEFAULT_VALUE = 100;
        private const bool DEFAULT_CHECKBOX2_CHECKED = true;
        private const bool DEFAULT_CHECKBOX3_CHECKED = false;

        // 현재값
        private bool _chkBoxDefault;
        private decimal _value;
        private bool _chkBox2Checked;
        private bool _chkBox3Checked;

        // 기본값이 아닌 가장 마지막 입력값
        private decimal _valueBackup;
        private bool _chkBox2Backup;
        private bool _chkBox3Backup;

        public StateDefaultImpl()
        {
            _observers = new List<StateObserver>();

            _chkBoxDefault = true;
            _value = DEFAULT_VALUE;
            _chkBox2Checked = DEFAULT_CHECKBOX2_CHECKED;
            _chkBox3Checked = DEFAULT_CHECKBOX3_CHECKED;

            _valueBackup = DEFAULT_VALUE;
            _chkBox2Backup = DEFAULT_CHECKBOX2_CHECKED;
            _chkBox3Backup = DEFAULT_CHECKBOX3_CHECKED;
        }

        public void registerObserver(StateObserver o)
        {
            _observers.Add(o);
        }

        public void removeObserver(StateObserver o)
        {
            _observers.Remove(o);
        }

        public void notifyObservers()
        {
            foreach (StateObserver observer in _observers)
            {
                observer.update();
            }
        }

        /// <summary>
        /// 값이 변경 되었을 때 저장된 값과 똑같으면 return 한다. Event Bubbling 방지
        /// 값이 변경되었다면 상태를 변경해주고, 마지막 입력값을 Backup 한다
        /// 값이 변경되었다면 기본값이 아니므로 해제해준다. (기본값과 동일여부도 따질 수 있겠지만.. 굳이)
        /// 옵저버들에게 값이 변경되었다는 알림을 보낸다.
        /// </summary>
        public decimal Value
        {
            get => _value;
            set
            {
                if (_value == value) return;
                _value = value;
                backup();
                _chkBoxDefault = false;
                notifyObservers();
            }
        }

        public bool ChkBox2Checked
        {
            get => _chkBox2Checked;
            set
            {
                if (_chkBox2Checked == value) return;
                _chkBox2Checked = value;
                backup();
                _chkBoxDefault = false;
                notifyObservers();
            }
        }

        public bool ChkBox3Checked
        {
            get => _chkBox3Checked;
            set
            {
                if (_chkBox3Checked == value) return;
                _chkBox3Checked = value;
                backup();
                _chkBoxDefault = false;
                notifyObservers();
            }
        }

        public bool ChkBoxDefault
        {
            get => _chkBoxDefault;
            set => _chkBoxDefault = value;
        }


        /// <summary>
        /// Default 가 체크 된다면 기본값을 보여준다.
        /// Default 가 체크가 해제 된다면 사용자가 입력한 가장 마지막 값을 보여준다
        /// </summary>
        public void ToggleDefaultCheckBox(bool chk)
        {
            if (chk == _chkBoxDefault) return;
            _chkBoxDefault = chk;

            if (chk)
            {
                setDefault();
            }
            else
            {
                restoreValue();
            }

            notifyObservers();
        }

        private void backup()
        {
            _valueBackup = _value;
            _chkBox2Backup = _chkBox2Checked;
            _chkBox3Backup = _chkBox3Checked;
        }

        private void restoreValue()
        {
            _value = _valueBackup;
            _chkBox2Checked = _chkBox2Backup;
            _chkBox3Checked = _chkBox3Backup;
        }

        private void setDefault()
        {
            _value = DEFAULT_VALUE;
            _chkBox2Checked = DEFAULT_CHECKBOX2_CHECKED;
            _chkBox3Checked = DEFAULT_CHECKBOX3_CHECKED;
        }

        public decimal ValueBackup
        {
            get => _valueBackup;
            set => _valueBackup = value;
        }

        public bool ChkBox2Backup
        {
            get => _chkBox2Backup;
            set => _chkBox2Backup = value;
        }

        public bool ChkBox3Backup
        {
            get => _chkBox3Backup;
            set => _chkBox3Backup = value;
        }

        public decimal GetDefaultValue()
        {
            return DEFAULT_VALUE;
        }

        public bool GetDefaultCheckBox2Checked()
        {
            return DEFAULT_CHECKBOX2_CHECKED;
        }

        public bool GetDefaultCheckBox3Checked()
        {
            return DEFAULT_CHECKBOX3_CHECKED;
        }
    }
}