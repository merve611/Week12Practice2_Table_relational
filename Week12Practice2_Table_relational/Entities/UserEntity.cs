namespace Week12Practice2_Table_relational.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<PostEntity> Posts { get; set; }     //Bir kullanıcının birden fazla postu olabilir
    }
}
