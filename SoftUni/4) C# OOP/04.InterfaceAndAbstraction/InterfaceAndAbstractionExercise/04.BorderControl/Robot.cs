﻿namespace BorderControl
{
    public class Robot
    {
        private string _id;
        private string _model;

        public Robot(string id, string model)
        {
            this.Id = id;
            this.Model = model;
        }

        public string Id
        {
            get => _id;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid id");
                }
                _id = value;
            }
        }

        public string Model
        {
            get => _model;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid model");
                }
                _model = value;
            }
        }
    }
}