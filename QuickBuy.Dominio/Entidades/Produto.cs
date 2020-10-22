namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public int Descricao { get; set; }
        public int Preco { get; set; }

        public override void Validate()
        {
            
        }
    }
}
