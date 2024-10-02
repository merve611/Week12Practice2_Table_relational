namespace Week12Practice2_Table_relational.Entities
{
    public class PostEntity             //gönderi classı
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public UserEntity User { get; set; }            //Her post sadece bir kullanıcı tarafından oluşturulmuştur
    }
}
