﻿using System.Windows.Input;
using Gemini.Framework.Commands;
using Gemini.Properties;

namespace Gemini.Modules.Shell.Commands
{
    [CommandDefinition]
    public class ExitCommandDefinition : CommandDefinition
    {
        public const string CommandName = "File.Exit";

        public override string Name
        {
            get { return CommandName; }
        }

        public override string Text
        {
            get { return Resources.FileExitCommandText; }
        }

        public override string ToolTip
        {
            get { return Resources.FileExitCommandToolTip; }
        }

        public override KeyGesture KeyGesture
        {
            get { return new KeyGesture(Key.F4, ModifierKeys.Alt); }
        }
    }
}