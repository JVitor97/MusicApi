namespace MusicApp.Dto
{
    public class AlbumDto
    {
        public string AlbumName { get; set; }
        public DateTime DateReleased { get; set; }
        public virtual ICollection<SongDto> Songs { get; set; }
    }
}
