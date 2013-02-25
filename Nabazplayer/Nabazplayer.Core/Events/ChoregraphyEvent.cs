using System;
using System.Collections.Generic;
using System.Text;

namespace Nabazplayer.Core.Events
{
    public class ChoregraphyEvent : NabaztagEvent
    {
        #region *********************** properties ***********************

        public int Tempo
        {
            get { return tempo; }
            set { tempo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        #endregion

        #region *********************** Constructors ***********************

        public ChoregraphyEvent()
        {
            commands = new List<ChoregraphyCommand>();
            tempo = 10;
        }

        public ChoregraphyEvent(string name)
            : this()
        {
            this.name = name;
        }

        public ChoregraphyEvent(string name, int tempo)
            : this()
        {
            this.tempo = tempo;
            this.name = name;
        }

        public ChoregraphyEvent(int tempo) : this()
        {
            this.tempo = tempo;
        }

        #endregion

        #region *********************** methods ***********************

        public override string GetEventString()
        {
            String command = "";
            foreach (ChoregraphyCommand element in commands)
            {
                command += element.GetCommandString() + ",";
            }
            command = command.Substring(0, command.Length - 1);

            return string.Format("chor={0},{1}&chortitle={2}", tempo.ToString(), command, name);
        }

        public void AddCommand(ChoregraphyCommand command)
        {
            if (!commands.Contains(command))
            {
                commands.Add(command);
            }
        }

        #endregion

        #region *********************** attrbutes ***********************

        private int tempo;
        private string name;
        private IList<ChoregraphyCommand> commands;

        #endregion


    }
}
