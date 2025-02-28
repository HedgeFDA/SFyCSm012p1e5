using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFyCSm012p1e5;

/// <summary>
/// Класс, представляющий пользователя
/// </summary>
public class User
{
    /// <summary>
    /// Логин пользователя
    /// </summary>
    public string? Login { get; set; }

    /// <summary>
    /// Имя пользователя
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Признак премиум статуса
    /// </summary>
    public bool IsPremium { get; set; }

    /// <summary>
    /// Инициализирует новый экземпляр класса.
    /// </summary>
    public User()
    {
        // Конструктор по умолчанию
    }
}