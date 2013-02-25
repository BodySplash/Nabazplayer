using System;
using System.Collections.Generic;
using System.Text;

namespace Nabazplayer.Core
{
    public class NabaztagEar
    {
        public enum Position
        {
            right = 0,
            left = 1
        }

        public enum Direction
        {
            Clockwise = 0,
            CouterClockwise = 1
        }

        #region *********************** Properties ***********************

        public Position EarPosition
        {
            get { return position; }
        }

        public int Angle
        {
            get { return angle; }
            set { angle = value; }
        }

        public Direction RotationDirection
        {
            get { return direction; }
        }

        #endregion

        #region *********************** Constructors ***********************

        internal NabaztagEar(Position position)
        {
            this.position = position;
            angle = 0;
            direction = Direction.Clockwise;
        }

        #endregion

        #region *********************** methods ***********************

        public NabaztagEar WithAngleAndDirection(int angle, Direction direction)
        {
            NabaztagEar retour = new NabaztagEar(position);
            retour.angle = angle;
            retour.direction = direction;

            return retour;
        }

        #endregion

        #region *********************** Attributes ***********************

        private Position position;
        private int angle;
        private Direction direction;

        #endregion
    }
}
