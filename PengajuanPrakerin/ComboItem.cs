
namespace PengajuanPrakerin
{
    // Kelas bantu supaya ComboBox bisa menyimpan Id + Text sekaligus
    public class ComboItem
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
