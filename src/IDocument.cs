using System;

namespace TeqBench.System.Data.NoSql.Models
{
    /// <summary>
    /// Base interface for a repository document model.
    /// </summary>
    /// <typeparam name="T">The instance type (i.e. domain model document type) of this document instance.</typeparam>
    public interface IDocument<T>
    {
        /// <summary>
        /// Unique identifier of document. This will generally be auto-generated when document is created in DB.
        /// </summary>
        T Id { get; set; }

        /// <summary>
        /// Creatation date/time of document instance.
        /// </summary>
        DateTime CreatedAt { get; }
    }
}
