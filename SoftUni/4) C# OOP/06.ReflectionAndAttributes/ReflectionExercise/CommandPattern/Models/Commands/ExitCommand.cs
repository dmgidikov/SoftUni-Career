﻿namespace CommandPattern.Models.Commands
{
    using Core.Contracts;

    public class ExitCommand : ICommand
    {
        public string Execute(string[] args)
        {
            Environment.Exit(0);
            return null;
        }
    }
}