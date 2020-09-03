using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAppi.Models
{
    public enum Gender
    {
        Male, Female
    }
    public interface IFormFile
    {
        string ContentType { get; }
        string ContentDisposition { get; }
        IHeaderDictionary Headers { get; }
        long Length { get; }
        string Name { get; }
        string FileName { get; }
        Stream OpenReadStream();
        void CopyTo(Stream target);
        Task CopyToAsync(Stream target, CancellationToken cancellationToken);
    }

    public class Dcandidate
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        // public Gender Gender { get; set; }
       public string  Gender { get; set; }
        public string PhotoName { get; set; }
        //[NotMapped]
        //public IFormFile? PersonalPhoto { get; set; }
        //[NotMapped]
        //public List<IFormFile>? Multiplefiles { get; set; }












    }
}
