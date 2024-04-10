namespace CL_PDomainPersistance
{
    public struct StructEgg
    {
        private float hauteurEnCms;
        private float largeurEnCms;
        private string typeChocolat;
        private int id;

        public float HauteurEnCms { get => hauteurEnCms; set => hauteurEnCms = value; }
        public int Id { get => id; set => id = value; }
        public float LargeurEnCms { get => largeurEnCms; set => largeurEnCms = value; }
        public string TypeChocolat { get => typeChocolat; set => typeChocolat = value; }
    }
}