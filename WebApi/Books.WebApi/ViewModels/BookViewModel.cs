using System;
using System.Collections.Generic;

namespace Books.WebApi.ViewModels
{
    public class BookViewModel
    {
        /// <summary>
        /// Book ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Page count
        /// </summary>
        public int PageCount { get; set; }

        /// <summary>
        /// Book publisher
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// Year of publication
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// International Standard Book Number
        /// </summary>
        public string Isbn { get; set; }

        /// <summary>
        /// Book cover image
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// The date the book was added
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// The date the book was edit
        /// </summary>
        public DateTime EditDate { get; set; }

        /// <summary>
        /// List of authors
        /// </summary>
        public IEnumerable<AuthorViewModel> Authors { get; set; }
    }
}
