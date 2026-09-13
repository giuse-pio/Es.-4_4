namespace LibraryN4_4
{
    public class Cerchio
    {
        public float Raggio { get; set; }
        public Cerchio() { }

        public Cerchio(float raggio)
        {
            Raggio = raggio;
        }
        public static Cerchio operator +(Cerchio c1, Cerchio c2)
        {
            if (c1 == null || c2 == null)
            {
                throw new ArgumentNullException("Impossibile sommare quadrati nulli.");
            }
            float area1 = (float)(Math.PI * c1.Raggio * c1.Raggio);
            float area2 = (float)(Math.PI * c2.Raggio * c2.Raggio);

            return new Cerchio(Math.Abs(area1 + area2));
        }

        public static Cerchio operator -(Cerchio c1, Cerchio c2)
        {
            if (c1 == null || c2 == null)
            {
                throw new ArgumentNullException("Impossibile sommare quadrati nulli.");
            }
            float area1 = (float)(Math.PI * c1.Raggio * c1.Raggio);
            float area2 = (float)(Math.PI * c2.Raggio * c2.Raggio);

            return new Cerchio(Math.Abs(area1 - area2));

        }

        public static bool operator ==(Cerchio c1, Cerchio c2)
        {
            if (ReferenceEquals(c1, c2))
            {
                return true;
            }
            if (ReferenceEquals(c1, null) || ReferenceEquals(c2, null))
            {
                return false;
            }

            return c1.Raggio == c2.Raggio;
        }
        public override string ToString()
        {
            return string.Format("C^{0}", Raggio);
        }
        public static bool operator !=(Cerchio c1, Cerchio c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Cerchio c)
            {
                return this == c;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Raggio.GetHashCode();
        }
        public static Cerchio Parse(string s)
        {
            if (string.IsNullOrEmpty(s) || !(s.StartsWith("C^")))
            {
                throw new FormatException("La stringa non è una rappresentazione valida di un quadrato (deve iniziare con 'C^').");
            }

            string stringa = s.Substring(2);

            try
            {
                float raggio = float.Parse(stringa);
                return new Cerchio(raggio);
            }
            catch (Exception ex)
            {
                throw new FormatException("Formato del valore del lato non valido.", ex);

            }
        }
    }
}
