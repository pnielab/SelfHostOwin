using Microsoft.Build.Framework;

namespace SelfHostOwin.Dtos
{
    public class DeviceFilterDto
    {
        public string Serial { get; set; }

        public string DeviceType { get; set; }

        [Required] public string Customer { get; set; }
    }
}