namespace Tanks
{
    class Tank : ICloneable, IComparable<Tank>
    {
        private string _name = "без назви";
        public string Name
        {
            get => _name;
            set
            {
                if (!String.IsNullOrEmpty(value)
                &&  !String.IsNullOrWhiteSpace(value))
                    _name = value;
            }
        }

        public int Strength { get; set; }
        public int Protection { get; set; }
        public int Speed { get; set; }
        public float Weight { get; set; }

        public Tank()
        {
            Strength = 0;
            Protection = 0;
            Speed = 0;
            Weight = 0f;
        }

        public Tank(string name, int strength, int protection, int speed, float weight)
        {
            Name = name;
            Strength = strength;
            Protection = protection;
            Speed = speed;
            Weight = weight;
        }

        public object Clone() => this.MemberwiseClone();

        public int CompareTo(Tank? other)
        {
            if (this is null || other is null)
                return 0;

            int res;

            if ((res = this.Name.CompareTo(other.Name)) != 0)
                return res;

            if ((res = this.Protection.CompareTo(other.Protection)) != 0)
                return res;

            if ((res = this.Strength.CompareTo(other.Strength)) != 0)
                return res;

            if ((res = this.Speed.CompareTo(other.Speed)) != 0)
                return res;

            return this.Weight.CompareTo(other.Weight);
        }

        public int CompareTo(Tank? other, IComparer<Tank> comparer)
        {
            return comparer.Compare(this, other);
        }

        public override string ToString()
        {
            return $"ТАНК [{_name}]" +
                $"\nсила =>\t|{Strength}|:" +
                $"\nзхст =>\t|{Protection}|:" +
                $"\nшвид =>\t|{Speed}|:" +
                $"\nвага =>\t|{Weight}|\n";
        }
    }
}