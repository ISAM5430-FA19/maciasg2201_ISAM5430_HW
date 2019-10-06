using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    class Money
    {
        private int _dollars;
        private int _cents;
        int _hundreds = 0, _fifties = 0, _twenties = 0, _tens = 0, _singles = 0, _quarters = 0, _dimes = 0, _nickels = 0, _pennies = 0;

        public Money(int dollars, int cents)
        {
            Dollars = dollars;
            Cents = cents;
            UpdateDenominations();
        }

        public Money(decimal amount) {
            Dollars = (int)amount;
            Cents = (int)(amount * 100) - (Dollars * 100);
            UpdateDenominations();
        }

        public int Dollars { get { return _dollars; } set{ _dollars = value; UpdateDenominations(); } }
        public int Cents { get { return _cents; } set { _cents = value; UpdateDenominations(); } }

        public override string ToString()
        {
            return $"${_dollars}.{_cents}";
        }

        public string Denominations()
        {
            String sDenominations = "";
            if (_hundreds > 0) { sDenominations += $"Hundreds:\t{_hundreds}\n"; }
            if (_fifties > 0) { sDenominations += $"Fifties:\t{_fifties}\n"; }
            if (_twenties > 0) { sDenominations += $"Twenties:\t{_twenties}\n"; }
            if (_tens > 0) { sDenominations += $"Tens:\t\t{_tens}\n"; }
            if (_singles > 0) { sDenominations += $"Singles:\t{_singles}\n"; }
            if (_quarters > 0) { sDenominations += $"Quarters:\t{_quarters}\n"; }
            if (_dimes > 0) { sDenominations += $"Dimes:\t\t{_dimes}\n"; }
            if (_nickels > 0) { sDenominations += $"Nickels:\t{_nickels}\n"; }
            if (_pennies > 0) { sDenominations += $"Pennies:\t{_pennies}\n"; }

            return sDenominations;
        }
        private void UpdateDenominations()
        {
            int dollars = _dollars;
            int cents = _cents;
            _hundreds = 0;
            _fifties = 0;
            _twenties = 0;
            _tens = 0;
            _singles = 0;
            _quarters = 0;
            _dimes = 0;
            _nickels = 0;
            _pennies = 0;

            if (dollars >= 100)
            {
                _hundreds = dollars / 100;
                dollars = dollars - (_hundreds * 100);
            }
            if (dollars >= 50)
            {
                _fifties++;
                dollars = dollars - 50;
            }
            if (dollars >= 20)
            {
                _twenties = dollars / 20;
                dollars = dollars - (_twenties * 20);
            }
            if (dollars >= 10)
            {
                _tens++;
                dollars = dollars - 10;
            }
            if (dollars >= 0)
            {
                _singles = dollars / 1;
            }

            if(cents >= 25)
            {
                _quarters = cents / 25;
                cents = cents - (_quarters * 25);
            }
            if(cents >= 10)
            {
                _dimes = cents / 10;
                cents = cents - (_dimes * 10);
            }
            if(cents >= 5)
            {
                _nickels = cents / 5;
                cents = cents - (_nickels * 5);
            }
            if(cents >= 1)
            {
                _pennies = cents / 1;
            }
        }
    }
}
