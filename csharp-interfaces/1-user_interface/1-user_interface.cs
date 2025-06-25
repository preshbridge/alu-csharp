using System;

/// <summary>
/// Base abstract class.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Name of the object.
    /// </summary>
    public string? name { get; set; }

    /// <summary>
    /// Provides a string representation of the object.
    /// </summary>
    /// <returns>String in the format: "name is a [type]"</returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}

/// <summary>
/// IInteractive interface.
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Interact with the object.
    /// </summary>
    void Interact();
}

/// <summary>
/// IBreakable interface.
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// Gets or sets the durability of the object.
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Break the object.
    /// </summary>
    void Break();
}

/// <summary>
/// ICollectable interface.
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Gets or sets whether the object is collected.
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Collect the object.
    /// </summary>
    void Collect();
}

/// <summary>
/// TestObject class inheriting from Base and implementing IInteractive, IBreakable, and ICollectable.
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// Durability of the object.
    /// </summary>
    public int durability { get; set; } // Implemented as a property.

    /// <summary>
    /// Indicates if the object is collected.
    /// </summary>
    public bool isCollected { get; set; } // Implemented as a property.

    /// <summary>
    /// Interact with the TestObject.
    /// </summary>
    public void Interact()
    {
        // Not fully implemented for this task.
        throw new NotImplementedException();
    }

    /// <summary>
    /// Break the TestObject.
    /// </summary>
    public void Break()
    {
        // Not fully implemented for this task.
        throw new NotImplementedException();
    }

    /// <summary>
    /// Collect the TestObject.
    /// </summary>
    public void Collect()
    {
        // Not fully implemented for this task.
        throw new NotImplementedException();
    }
}