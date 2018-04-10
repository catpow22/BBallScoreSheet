using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBallScoreSheet.Models
{
    public class Player : ObservableObject
    {
        #region Fields

        private int _totalPoints;
        private string _playertName;
        private int _twoPointFG;

        #endregion // Fields

        #region Properties

        public int TotalPoints
        {
            get { return _totalPoints; }
            set
            {
                if (value != _totalPoints)
                {
                    _totalPoints = value;
                    OnPropertyChanged("TotalPoints");
                }
            }
        }

        public string PlayerName
        {
            get { return _playertName; }
            set
            {
                if (value != _playertName)
                {
                    _playertName = value;
                    OnPropertyChanged("PlayerName");
                }
            }
        }

        public int TwoPointFG
        {
            get { return _twoPointFG; }
            set
            {
                if (value != _twoPointFG)
                {
                    _twoPointFG = value;
                    OnPropertyChanged("TwoPointFG");
                }
            }
        }

        #endregion // Properties    
    }
 }
