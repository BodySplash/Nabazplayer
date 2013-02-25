using System;
using System.Collections.Generic;
using System.Text;

namespace Nabazplayer.Core.Events
{
    /// <summary>
    /// Describe a ear movement în a choregraphy
    /// </summary>
    public class ChoregraphyEarCommand : ChoregraphyCommand
    {

        #region *********************** properties ***********************

        public NabaztagEar Ear
        {
            get { return ear; }
            set { ear = value; }
        }

        #endregion

        #region *********************** constructors ***********************

        public ChoregraphyEarCommand(NabaztagEar ear, int time)
            : base("motor")
        {
            this.ear = ear;
            this.Time = time;
        }

        #endregion

        #region *********************** Methods ***********************

        protected override string GetCommandStringCore()
        {
            return string.Format("{0},{1},0,{2}", ((int)ear.EarPosition).ToString(), ear.Angle.ToString(), ((int)ear.RotationDirection).ToString());
        }

        #endregion

        #region *********************** attributes ***********************

        private NabaztagEar ear;


        #endregion
    }
}
