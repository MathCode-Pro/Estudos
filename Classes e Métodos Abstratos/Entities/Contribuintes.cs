namespace Classes_e_Métodos_Abstratos.Entities {
    internal abstract class Contribuintes {

        internal string Name { get; private set; }
        internal double AnualIncome { get; private set; }

        internal Contribuintes(string name, double anualIncome) {
            Name = name;
            AnualIncome = anualIncome;
        }

        internal abstract double ImpostoPago();

        public override string ToString() {
            return $"{Name}: $ {ImpostoPago():F2}";
        }
    }
}
