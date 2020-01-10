using System;

namespace Books.WebApi.ViewModels
{
    public class AuthorViewModel
    {
        /// <summary>
        /// Author ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Book ID
        /// </summary>
        public Guid BookId { get; set; }
    }
}
