
# Strategy Design Pattern


The Strategy design pattern is a behavioral design pattern that allows you to define a family of algorithms, encapsulate each algorithm, and make them interchangeable. This pattern is particularly useful when you have multiple algorithms or strategies that can be used to accomplish a specific task, and you want to be able to switch between these strategies easily without changing the client code that uses them.

**Real-Life Example** :- Let's consider a payment processing system that supports different payment methods (credit card, PayPal, and cryptocurrency) using the Strategy design pattern in C#.
## Code

```
//Define the strategy interface:
public interface IPaymentStrategy
{
    void ProcessPayment(double amount);
}


//Implement concrete strategy classes:
public class CreditCardPaymentStrategy : IPaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        // Implement credit card payment processing here
    }
}

public class PayPalPaymentStrategy : IPaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        // Implement PayPal payment processing here
    }
}

public class CryptocurrencyPaymentStrategy : IPaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        // Implement cryptocurrency payment processing here
    }
}


//Create a context class that uses the strategy:
public class PaymentContext
{
    private IPaymentStrategy _paymentStrategy;

    public PaymentContext(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void ProcessPayment(double amount)
    {
        _paymentStrategy.ProcessPayment(amount);
    }
}


//Use the payment processing system:
class Program
{
    static void Main(string[] args)
    {
        double paymentAmount = 100.00;

        PaymentContext context = new PaymentContext(new CreditCardPaymentStrategy());
        context.ProcessPayment(paymentAmount);
        
        // You can switch to a different payment strategy at runtime
        context.SetPaymentStrategy(new PayPalPaymentStrategy());
        context.ProcessPayment(paymentAmount);
    }
}


```
## FAQ

#### 1. When should I use the Strategy pattern?

Use the Strategy pattern when you have a family of related algorithms or behaviors that you want to encapsulate and make interchangeable. It's especially useful when you want to switch between these algorithms at runtime without altering the client code.

#### 2. What are the benefits of using the Strategy pattern?

* Flexibility: You can easily switch algorithms or behaviors at runtime without changing the client code.
* Modularity: Each strategy is encapsulated in its own class, promoting cleaner and more maintainable code.
* Extensibility: New strategies can be added without modifying existing code.
* Testability: Strategies can be tested independently.

#### 3. How does the Strategy pattern differ from the Template Method pattern?

The Strategy pattern focuses on encapsulating algorithms and making them interchangeable, whereas the Template Method pattern provides a skeleton for an algorithm, allowing subclasses to provide specific implementations for certain steps. While both patterns involve encapsulating behaviors, the key difference is that the Strategy pattern emphasizes swapping out entire algorithms, while the Template Method pattern emphasizes defining a template for an algorithm.

#### 4. Can I combine the Strategy pattern with other design patterns?

Yes, you can combine the Strategy pattern with other patterns as needed. For example, you might use the Factory Method pattern to create instances of different strategies, or you could use the Observer pattern to notify objects about strategy changes.

#### 5. Is the Strategy pattern only applicable in object-oriented programming?

The Strategy pattern is closely tied to object-oriented programming concepts, but you can apply similar principles in other paradigms as well. In functional programming, for instance, you might achieve similar flexibility by using higher-order functions or passing functions as arguments.

#### 6. Are there any downsides to using the Strategy pattern?

* Complexity: Introducing multiple strategy classes can increase the number of classes in your codebase, potentially adding complexity.
* Indirection: Depending on the implementation, there might be an additional level of indirection when invoking strategies.
* Overhead: There can be some overhead associated with creating strategy objects, especially in scenarios where strategies are frequently switched.

#### 7. Can I change strategies dynamically while the program is running?

Yes, that's one of the key features of the Strategy pattern. You can change the strategy dynamically at runtime, allowing you to adapt to different situations without stopping the program.

#### 8.Is the Strategy pattern the same as the State pattern?

While both patterns involve encapsulating behaviors, they have different focuses. The Strategy pattern is about interchangeable algorithms, while the State pattern deals with changing the behavior of an object as its internal state changes.

#### 9. Where can I find real-world examples of the Strategy pattern?

You can find examples in various software systems:

GUI toolkits that allow users to choose different layout strategies.
Games with different AI strategies for opponents.
Text editors with various strategies for searching and replacing text.
Financial applications with different strategies for calculating interest.

#### 10. Can a class be a Strategy and a Context at the same time?

Yes, it's possible, but it's important to consider the Single Responsibility Principle. While a class can implement multiple strategies, combining too many responsibilities can make the class complex and harder to maintain. It's often better to separate the roles of strategies and context into distinct classes for better modularity.


## Tech Stack

**Language:** C#

**Framework:** .NET Core


## License

[MIT](https://choosealicense.com/licenses/mit/)

