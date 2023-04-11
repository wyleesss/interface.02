namespace Tanks
{
    namespace Comparers
    {
        class StrengthComparer : IComparer<Tank>
        {
            public int Compare(Tank? t1, Tank? t2)
            {
                if (t1 is null || t2 is null)
                    return 0;

                int res;

                if ((res = t1.Strength.CompareTo(t2.Strength)) != 0)
                    return res;

                if ((res = t1.Protection.CompareTo(t2.Protection)) != 0)
                    return res;

                if ((res = t1.Speed.CompareTo(t2.Speed)) != 0)
                    return res;

                if ((res = t1.Weight.CompareTo(t2.Weight)) != 0)
                    return res;

                return t1.Name.CompareTo(t2.Name);
            }
        }

        class ProtectionComparer : IComparer<Tank>
        {
            public int Compare(Tank? t1, Tank? t2)
            {
                if (t1 is null || t2 is null)
                    return 0;

                int res;

                if ((res = t1.Protection.CompareTo(t2.Protection)) != 0)
                    return res;

                if ((res = t1.Strength.CompareTo(t2.Strength)) != 0)
                    return res;

                if ((res = t1.Speed.CompareTo(t2.Speed)) != 0)
                    return res;

                if ((res = t1.Weight.CompareTo(t2.Weight)) != 0)
                    return res;

                return t1.Name.CompareTo(t2.Name);
            }
        }

        class SpeedComparer : IComparer<Tank>
        {
            public int Compare(Tank? t1, Tank? t2)
            {
                if (t1 is null || t2 is null)
                    return 0;

                int res;

                if ((res = t1.Speed.CompareTo(t2.Speed)) != 0)
                    return res;

                if ((res = t1.Protection.CompareTo(t2.Protection)) != 0)
                    return res;

                if ((res = t1.Strength.CompareTo(t2.Strength)) != 0)
                    return res;

                if ((res = t1.Weight.CompareTo(t2.Weight)) != 0)
                    return res;

                return t1.Name.CompareTo(t2.Name);
            }
        }

        class WeightComparer : IComparer<Tank>
        {
            public int Compare(Tank? t1, Tank? t2)
            {
                if (t1 is null || t2 is null)
                    return 0;

                int res;

                if ((res = t1.Weight.CompareTo(t2.Weight)) != 0)
                    return res;

                if ((res = t1.Protection.CompareTo(t2.Protection)) != 0)
                    return res;

                if ((res = t1.Strength.CompareTo(t2.Strength)) != 0)
                    return res;

                if ((res = t1.Speed.CompareTo(t2.Speed)) != 0)
                    return res;

                return t1.Name.CompareTo(t2.Name);
            }
        }

    }
}
