﻿using System.ComponentModel.DataAnnotations;

namespace BookStore.Domain.Model;
/// <summary>
/// Связь автора и издания
/// </summary>
public class BookAuthor
{
    /// <summary>
    /// Идентификатор связи
    /// </summary>
    [Key]
    public required int Id { get; set; }

    /// <summary>
    /// Идентификатор автора
    /// </summary>
    public required int AuthorId { get; set; }

    /// <summary>
    /// Навигейшен автора
    /// </summary>
    public virtual Author? Author { get; set; }

    /// <summary>
    /// Идентификатор издания
    /// </summary>
    public required int BookId { get; set; }

    /// <summary>
    /// Навигейшен издания
    /// </summary>
    public virtual Book? Book { get; set; }
}
