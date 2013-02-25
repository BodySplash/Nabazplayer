using System;
using System.Collections.Generic;
using System.Text;

namespace Nabazplayer.Core.Events
{
    /// <summary>
    /// Base class for choregraphy commands
    /// </summary>
    public abstract class ChoregraphyCommand
    {
        #region *********************** properties ***********************

        public int Time
        {
            get { return time; }
            set { time = value; }
        }

        #endregion

        #region *********************** Constructors ***********************

        public ChoregraphyCommand(string commandName)
        {
            this.commandName = commandName;
            time = 0;
        }

        #endregion

        #region *********************** methods ***********************

        public string GetCommandString()
        {
            return string.Format("{0},{1},{2}", time.ToString(), commandName.ToString(), GetCommandStringCore());
        }

        protected abstract string GetCommandStringCore();

        #endregion

        #region *********************** attributes ***********************

        private int time;
        private string commandName;

        #endregion
    }
}
