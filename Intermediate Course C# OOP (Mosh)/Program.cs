using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using Intermediate_Course_C__OOP__Mosh_.Stop_Watch_Exercise;
using Intermediate_Course_C__OOP__Mosh_.StockOverflow_Post_Exercise;
using System.Collections.Concurrent;
using Intermediate_Course_C__OOP__Mosh_.Stack_Exercise__Inheritance_;
using Intermediate_Course_C__OOP__Mosh_.Database_Connection_Exercise__Polymorphism_;
using Intermediate_Course_C__OOP__Mosh_.Workflow_Exercise__Interface_;

namespace Intermediate_Course_C__OOP__Mosh_
{
    internal class Program
    { 
        public static void Main(string[] args)
        {
            //CLASSES
            #region
            ////Creating an object from the Classes Class through INSTANTIATION
            //var classes = new Classes();
            ////Setting the Name Field inside the Classes Class to Alex
            //classes.Name = "Alex";
            ////Calling the Introduce Method inside the Classes Class
            //classes.Introduce("Mosh");

            ////Creating a classes object FROM A STRING - with this we will create a Parse Method
            ////inside the Classes Class. Using the static property of Parse Metod
            //var classes = Classes.Parse("Alex");
            //classes.Introduce("Mosh");
            #endregion

            //CONSTRUCTORS
            #region
            ////A Constructor is a method that is called when an instance of a class is created.
            ////We use CONSTRUCTORS to PUT AN OBJECT IN AN EARLY STATE or to INITIALIZE SOME FIELDS IN AN EARLY STATE.
            ////IMPORTANT: A Constructor SHOULD BE THE SAME NAME AS THE CLASS and DOES NOT HAVE A RETURN TYPE.

            ////RULE OF THUMB: We should only use CONSTRUCTORS when we need to initialize our fields BASED ON THE 
            ////VALUES PASSED FROM THE OUTSIDE.

            ////Instantiating an object from the Constructors Class
            //var constructor = new Constructors(1, "Alex");
            //Console.WriteLine(constructor.Id);
            //Console.WriteLine(constructor.Name);

            ////Another Example of initializing the Fields to an early state (List<Order>) using the Oreder Class
            //var oder = new Order();
            //constructor.Orders.Add(oder);
            #endregion

            //OBJECT INITIALIZERS
            #region
            ////It is a syntax for quickly initializing an object WITHOUT THE NEED TO CALL
            ////ONE OF ITS CONSTRUCTORS. We need this for us to AVOID CREATING TOO MANY CONSTRUCTORS.

            ////So with the use of Object Initializer, we could initialize the fields from 
            ////ObjectInitializer Class like this: 
            //var objectInitializer = new ObjectInitializer()
            //{
            //    FirstName = "Alex",
            //    LastName = "Soliven"
            //};
            #endregion

            //METHODS
            #region
            ////SIGNATURE OF A METHOD - it consists of it's Name, and the Number and type of its parameters
            ////Method Overloading - Having a method with same name BUT DIFFERENT SIGNATURES.

            ////NOTE: The best thing to user when it comes to a METHOD WITH VARYING NUMBER OF PARAMETERS is
            ////to USE AN ARRAY(ex. int[] numbers or string[] names) WTIH PARAMS Modifier.

            ////This is an example of a Method with varying number of parameters WITHOUT THE PARAMS
            //var methodsWithDynamicParameters = new Methods();
            //var withoutParams = methodsWithDynamicParameters.Add(new int[] { 1, 2, 3, 4, 5 });

            ////Using the Params Modifier, it will be easier for us to add the arguments on each of its parameters
            //var withParams = methodsWithDynamicParameters.Add(1, 2, 3, 4, 5);

            ////Here the class that we're going to use as an example is the Point Class
            //var point = new Point(10, 20);
            ////Here we will use the Overloading Method that takes an instance of an object
            //point.Move(new Point(40, 60));
            //Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);

            ////Here we will use the first overload on the Move Method
            //point.Move(100, 200);
            //Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);
            #endregion

            //FIELDS
            #region
            //var fields = new Fields(1);
            //fields.Orders.Add(new Order());
            //fields.Orders.Add(new Order());
            ////Displaying the count of Orders in the console.
            //Console.WriteLine("Count of orders is: {0}", fields.Orders.Count());
            #endregion

            //ACCESS MODIFIERS
            #region
            ////Accessing the fields with PRIVATE DECLARATION
            //var accessModifiers = new AccessModifiers();
            //accessModifiers.SetName("Alexander");
            //accessModifiers.SetBirthdate(new DateTime(1998, 09, 26));
            ////Displaying the Name and Birthdate in the console.
            //Console.WriteLine("Your name is: {0}", accessModifiers.GetName());
            //Console.WriteLine("Your birthdate is: {0}", accessModifiers.GetBirthdate());
            #endregion

            //PROPERTIES
            #region
            ////Setting the Birthdate and displaying the Age.
            ////Using the Birthdate property WITHOUT THE PRIVATE MODIFIER ON THE SET PROPERTY
            ////var properties = new Properties();
            ////properties.Birthdate = new DateTime(1998, 09, 26);
            ////Console.WriteLine("Your current age is: {0}", properties.Age);

            ////----------------------------------------------------------------------------------------------

            ////Setting the Birthdate Field THROUGH CONSTRUCTOR BECAUASE OF THE PRIVATE MODIFIER ON THE SET PROPERTY
            //var properties = new Properties(new DateTime(1998, 09, 26));
            //Console.WriteLine("Your current age is: {0}", properties.Age);
            #endregion

            //INDEXERS
            #region
            ////Indexers - are way to access elements in a class that represents a list of values.
            //var indexers = new Indexers();
            //indexers["name"] = "Alex";

            ////Displaying the name on the console
            //Console.WriteLine("The value of the name key is: {0}", indexers["name"]);
            #endregion

            //STOPWATCH EXERCISE
            #region
            //var stopwatch = new Stopwatch();
            //Console.WriteLine("Would you like to start the Stopwatch? (Yes/No)");
            //var startingStopwatch = Console.ReadLine().Trim().ToLower();
            //if (startingStopwatch == "yes")
            //{
            //    var isContinue = true;
            //    do 
            //    {
            //        Console.WriteLine("To start the timer, please type 'Start': ");
            //        var timerStart = Console.ReadLine().Trim().ToLower();

            //        if (timerStart == "start")
            //            stopwatch.Start();
            //        Console.WriteLine("The Stopwatch has been started.");

            //        Console.WriteLine("To check the timer, please type 'Stop': ");
            //        var timerStop = Console.ReadLine().Trim().ToLower();
            //        if (timerStop == "start")
            //            throw new InvalidOperationException("We cannot start the Stopwatch consecutively.");

            //        if (timerStop == "stop")
            //            Console.WriteLine("The duration is {0}", stopwatch.Stop());

            //        Console.WriteLine("Would you like to start again? (Yes/No)");
            //        var loopAgain = Console.ReadLine().Trim().ToLower();
            //        if (loopAgain == "no")
            //        {
            //            isContinue = !isContinue;
            //            break;
            //        }

            //    } while (isContinue);

            //}
            //else
            //{
            //    Console.WriteLine("The Stopwatch is not started.");
            //}
            #endregion

            //STACKOVERFLOW POST EXERCISE
            #region
            //var post = new Post();
            //post.CreatePost();
            //while (true)
            //{
            //    Console.WriteLine("Up Vote or Down Vote? (Up/Down) ");
            //    var voting = Console.ReadLine().Trim().ToLower();
            //    if (voting == "up")
            //    {
            //        post.UpVote();
            //        Console.WriteLine("Tittle: "+post.Tittle );
            //        Console.WriteLine("Tittle: "+post.Description );
            //        Console.WriteLine("Tittle: "+post.DateTime);
            //        Console.WriteLine("Vote: " + post.GetVoteCounts);
            //    }

            //    if (voting == "down")
            //    {
            //        post.DownVote();
            //        Console.WriteLine("Tittle: " + post.Tittle);
            //        Console.WriteLine("Tittle: " + post.Description);
            //        Console.WriteLine("Tittle: " + post.DateTime);
            //        Console.WriteLine("Vote: " + post.GetVoteCounts);
            //    }

            //}
            #endregion'

            //CLASS COUPLING
            #region
            //COUPLING - a measure of how interconnected classes and subsystems are.

            //TIGHTLY COUPLED DESIGN(Application with tightly coupled classes or methods)
            //- an application whose classes are TIGHTLY RELATED ARE DEPENDENT ON EACH OTHER.
            //IT IS A BAD DESIGN.

            //LOOSELY COUPLED DESIGN(Application with loosely coupled classes or methods)
            //- THIS IS THE IDEAL SOFTWARE DESIGN, in order for us to MINIMIZE CHANGES IN OUR
            //APPLICATION.

            //HOW TO DESIGN A LOOSELY COUPLED APPLICATION
            //* ENCAPSULATION
            //* THE RELATIONSHIPS BETWEEN CLASSES
            //* INTERFACES

            //TYPES OF RELATIONSHIPS
            //INHERITANCE
            //COMPOSITION
            #endregion

            //INHERITANCE
            #region
            ////Inheritance - A kind of relationship bet two classes that allows one
            ////to inherit code from the other classes. It is a Parent Calss and a 
            ////Child Class relationship. It's purpose is to write the code once and
            ////RE-USE it in multiples classes.

            ////Benefits of Ingeritance
            ////*Code re-use - means that the code from the Parent Class can be used or
            ////re-use on the child class.
            ////*Polymporphic behaviour

            ////NOTE: A class SHOULD ONLY HAVE ONE PARENT

            ////Now lets see the parent and the child class in action
            //var childClass1 = new ChildClass1();
            ////Since this childClass1 inherited the Parent Class, now we can use the different
            ////Methods and properties that this Parent Class have
            //childClass1.Copy();
            //childClass1.Duplicate();
            //childClass1.Width = 100;
            //childClass1.Height = 200;

            ////but we can also use its own properties and Methods
            //childClass1.AddHyperlink("This is the URL");
            //childClass1.FontName = "This is the Font Name";
            //childClass1.FontSize = 100;
            #endregion

            //COMPOSITION
            #region
            ////It is a kind of relationship bet two classes that allows one to contain the other.
            ////It is a Has-a RELATIONSHIP. Example: Car Has an Engine.

            ////Benefits of using Composition:
            ////*We can also have Code re-use just like the Inheritance
            ////*It is MORE FLEXIBLE and it is a means to DESIGNING LOOSELY COUPLED APPLICATION.

            ////First Create the LoggerClassComposition Class, Next is the DbMigratorComposition Class,
            ////and lastly the InstallerClassComposition

            ////Now we after implementing the Composition to the Classes LoggerClassComposition,
            ////InstallerClassComposition and DbMigratorComposition we can now implement it here.

            ////Here we need to pass a logger object, and one way to do is to create another object
            ////as an Argument on the DbMigratorComposition() Constructor.
            ////var dbMigrator = new DbMigratorComposition(new LoggerClassComposition());

            ////Another way is create another variable and assign it to new LoggerClassComposition() and
            ////pass it on the DbMigratorComposition(Argument) Constructor.
            //var logger = new LoggerClassComposition();
            //var dbMigrator = new DbMigratorComposition(logger);
            ////Same goes on the InstallerClassComposition when creating an instance on this class, we need
            ////to pass an object to its Constructor.
            //var installer = new InstallerClassComposition(logger);

            ////Now we can call the methods inside the DbMigrator and the Installer Class
            //dbMigrator.Migrate();
            //installer.Install();


            ////Using the PersonComposition, DogCompostion and AnimalComposition to see if I really get the
            ////concept of Composition the goal is to use the fields and methods of the AnimalComposition
            ////to both the PersonComposition and DogCompostion Classes
            //var animal = new AnimalComposition();
            //var walkable = new WalkableClassComposittion_cs();

            //var person = new PersonComposition(animal, walkable);
            //var dog = new DogComposition(animal, walkable);

            //person.SetAge(25);
            //person.PersonSleeping();
            //person.PersonEating();
            //person.PersonWalking();

            //dog.SetAge(4);
            //dog.DogEat();
            //dog.DogSleep();
            //dog.DogWalk();

            ////Implementing Composition to Class Duck from Animal and Swimmable Classes
            ////A Duck can walk, sleep and swim.
            ////var animal = new AnimalComposition();
            //var swimmable = new SwimmableCompostionClass();

            //var duck = new DuckCompositionClass(animal, swimmable);
            //duck.DuckEat();
            //duck.DuckSleep();
            //duck.DuckSwim();
            #endregion

            //FAVOUR COMPOSITION OVER INHERITANCE
            #region
            //Problems with Inheritance
            //*It can be easily abused by amateur designers or developers
            //*Large hirarchies of classes, meaning if you CHANGE A CLASS ON
            //TOP of the hierarchy ALL THE CLASSES INHERITED FROM IT WILL BE AFFECTED.
            //And this is beacuase of the TIGHT COUPLING that comes with inheritance.
            //*Fragility
            #endregion

            //ACCESS MODIFIERS
            #region
            //Different Access Modifiers:
            //public - the member is accessible everywhere
            //private - the member is only accessible from that specific class
            //protected - the member is only accessible from the class and its derived classes
            //internal - the members is accessible only from the same assembly.
            //protected internal - the members is accessible only from the same assembly or any
            //derived classes.

            //Public Access Modifiers Example from PublicAccessModifiersClass

            //Note: It is better to use the PUBLIC and PRIVATE Access Modifiers rather the other
            //access modifiers because they are considered as bad design on the C# Language.
            #region
            //var publicAccessMod = new PublicAccessModifiersClass();

            ////Since we're using public access mod we're able to see those properties and methods.
            //publicAccessMod.Id = 12;
            //publicAccessMod.Name = "Alexander";
            //publicAccessMod.Promote();
            #endregion

            #endregion

            //CONSTRUCTORS AND INHERITANCE
            #region
            //Two thing that we need to know about CONSTRUCTORS when it comes to INHERITANCE
            //(1) - Base class constructors are ALWAYS EXECUTED FIRST.
            //(2) - Base class construstors are NOT INHERITED. Meaning in a derived class you
            //need to REDEFINE YOUR CONSTRUCTORS.

            ////Running the examples from Vehicle and Car Class, their constructors that has
            ////NO PARAMETERS. First we need to initialize the Car Class for us to have an Object.
            //var car = new Car_DerivedClass_ConstructorInheritance();
            ////When we ran the application, we can see that THE CONSTRUCTORS OF THE BASE CLASS 
            ////IS ALWAYS EXECUTED FIRST.


            //Lets take a look at the use of Base Keyword, Running the examples from Vehicle and Car Class, their constructors that has
            //PARAMETERS
            //var car = new Car_DerivedClass_ConstructorInheritance("24262753");
            #endregion

            //UPCASTING AND DOWNCASTING
            #region
            ////Upcasting - it is the CONVERSION from a DERIVED CLASS to a BASE CLASS
            ////Downcasting - it is the CONVERSION from a BASE CLASS to a DERIVED CLASS


            ////Creating a Object of type Text
            //DerivedClassText_UpAndDownCasting text = new DerivedClassText_UpAndDownCasting();

            ////UPCASTING
            //BaseClassShape_UpAndDownCasting shape = text;
            ////Now we successfully converted implicitly an object reference like text to its base class
            ////reference shape. Although this text and shape object points to the same reference in the memory,
            ////they have DIFFERENT VIEWS.

            ////We can now use all the properties of the text class and the shape class since text is
            ////derived from the shape class using the keyword "text." but when we use the keyword 
            ////"shape." we cannot use the FontSize and FontName property from the text class.
            ////Example:
            //text.Width = 200;
            ////Since text and shape refer to the same object but have different views, we can use the 
            ////shape to modify the width of the text object. We will set it to 100.
            //shape.Width = 100;
            ////Now to see the configured value of the Width, we will print it on the console.
            //Console.WriteLine("The value of the Width is: {0}", text.Width);
            //Console.WriteLine("The value of the Width is: {0}", shape.Width);
            ////IMPORTANT: The point of CONVERTING an OBJECT REFERENCE TO ITS BASE CLASS REFERENCE is very powerful
            ////which leads to POLYMORPHISM.

            ////DOWNCASTING
            //BaseClassShape_UpAndDownCasting shape = new DerivedClassText_UpAndDownCasting();
            ////Here if we type "shape." we have a very limited view, WE CANNOT USE the PROPERTIES
            ////FROM THE TEXT CLASS. So inorder for us to use the properties of Text Class, WE NEED TO
            ////DOWNCAST.
            //shape.X = 10;
            //shape.Y = 20;
            //shape.Height = 30;
            //shape.Width = 50;

            ////Now we will convert the shape to a text
            //DerivedClassText_UpAndDownCasting text = (DerivedClassText_UpAndDownCasting)shape;
            ////And now we will have the access to every property in the Text Class.
            //text.X = 5;
            //text.Y = 5;
            //text.Height = 5;
            //text.Width = 5;
            //text.FontName = "This is Text";
            //text.FontSize = 5;

            #endregion

            //STACK EXERCISE FOR INHERITANCE
            #region
            //Stack_Exercise stack = new Stack_Exercise();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(null);

            //stack.Pop();
            //stack.Pop();
            //stack.Pop();
            //stack.Pop();
            //stack.Clear();
            //stack.Pop();
            #endregion

            //METHOD OVERRIDING
            #region
            ////Method Overriding - modifying the implementation of an INHERITED METHOD.
            ////There are times when we want to modify the implementation of a method that
            ////we INHERITED FROM A BASE CLASS and maybe that implementation DOESN'T APPLY
            ////TO A DERIVED CLASS, that's where WE CAN USE METHOD OVERRIDING. We OVERRIDE 
            ////THE IMPLEMENTATION OF AN INHERITED METHOD.

            ////First we create a LIST OF SHAPES
            //List<MethodOverridingBaseClass> shapes = new List<MethodOverridingBaseClass>();

            ////Now we will add objects of type Base Class (Could be a Circle and a Rectangle since they
            ////inherited from the Base Class).
            //shapes.Add(new MethodOverridingDerivedClassCircle());
            //shapes.Add(new MethodOverridingDerivedClassRectangle());

            ////We instantiate an object from the Canvas Class
            //var canvas = new MethodOverridingCanvasClass();
            ////We will execute the method of the MethodOverridingCanvasClass
            //canvas.DrawShapes(shapes);
            ////The "shapes" list where we stored the objects that we added would become the ARGUMENT FOR THE
            ////DrawShapes(List of objects) Method.

            ////NOTE: Through the use of POLYMORPHISM we can add different shapes (like triangle) by simply
            ////creating a new class for triangle and inherit the base class for us to be able to override 
            ////the Draw() Method without affecting or impacting with our existing classes. THIS IS VERY POWERFUL.
            #endregion

            //ABSTRACT CLASSES AND MEMBERS
            #region
            //Abstract Modifier - Indicates that a class or a member is missing implementation.


            //RULES THAT NEED TO KNOW WHEN WORKING WITH ABSTRACT MEMBERS:

            //1.An Abstract member CANNOT include implementation.
            //Ex. public absrtact void Draw();
            //It does not have a body or implementation only declaration. The Class that will inherit
            //from the Base Class where the Draw() Method is declared, will be the on wwho will OVERRIDE
            //and PUT THE IMPLEMENTATION on the Draw() Method.

            //2. If a member is declared as abstract, the containing class NEEDS TO BE DECLARED AS ABSTRACT TOO
            //Example:
            //public abstract class BaseClass
            //{ 
            //public abstract void Draw();
            //}

            //3. In the derived class, YOU MUST IMPLEMENT ALL ABSTRACT MEMBERS IN THE BASE ABSTRACT CLASS.
            //So in our case here the BaseClass only have ONE ABSTRACT METHOD, but if the BaseClass have 
            //THREE ABSTRACT METHODS YOU NEE TO OVERRIDE ALL THIS THREE ABSTRACT METHODS.
            //Example
            //public class Circle : BaseClass
            //{
            //     public override void Draw()
            //      {
            //          Implementaion for Circle
            //      }
            //{

            //4. Abstract Classes CANNOT BE INSTANTIATED.
            //Example: BaseClass shape = new BaseClass();   //WON'T COMPILE

            //Why do we use ABSTRACT?
            //We use ABSTRACT when you WANT TO PROVIDE SOME COMMON BEHAVIOUR, while FORCING OTHER DEVS
            //TO FOLLOW YOUR DESIGN.

            ////Using the AbstractBaseClass, AbstractDerivedClassCircle and AbstractDerivedClassRectangle
            //var circle = new AbstractDerivedClassCircle();
            //circle.Draw();
            ////We can also use the common members from the BaseClass
            //circle.Copy();
            //circle.Select();

            //var rectangle = new AbstractDerivedClassRectangle();
            //rectangle.Draw();
            ////We can also use the common members from the BaseClass
            //rectangle.Copy();
            //rectangle.Select();
            #endregion

            //POLYMORPHISM Exercise : Design Database Connection
            #region
            ////Using the DbConnectionBaseClass, OracleConnection, SqlConnection and DbCommand
            ////Instantiating Objects for sql and oracle
            //SqlConnection sqlConnectionString = new SqlConnection("This is Sql Connection String.");
            //OracleConnection oracleConnectionString = new OracleConnection("This is Oracle Connection String.");
            ////DbCommand dbCommand = new DbCommand(oracleConnectionString.ConnectionString, "This is the needed instruction to execute");
            //DbCommand dbCommand = new DbCommand(oracleConnectionString.ConnectionString, "This is the needed instruction to execute");
            //dbCommand.Execute();
            #endregion

            //EXERCISE FOR C# WITH LOVE
            #region
            //Exercise : Reverse the input string
            #region
            //var inputString = "Monina Ganda";
            //var inputLength = inputString.Length;

            //for (int i = inputLength - 1; i >= 0; i--)
            //{
            //    Console.Write(inputString[i]);
            //}
            #endregion

            //Exercise : Adding the first element at the start and end of the input string
            #region
            //var inputString = "The quick brown fox jumps over the lazy dog.";
            //var elementToAdd = inputString[0];

            //Console.WriteLine($"{elementToAdd}{inputString}{elementToAdd}");
            #endregion

            //Exercise : Return True or False
            #region
            //Console.WriteLine("Please enter the first number: ");
            //var firstNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the second number: ");
            //var secondNumber =Convert.ToInt32(Console.ReadLine());

            //var determineSign = firstNumber * secondNumber;
            //if ( determineSign < 0 )
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            #endregion

            //Exercise : Sum of Two Integers
            #region
            //Console.WriteLine("Please enter the first number: ");
            //var firstNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the second number: ");
            //var secondNumber = Convert.ToInt32(Console.ReadLine());

            //if (firstNumber == secondNumber)
            //{
            //    var tripleTheSum = (firstNumber + secondNumber) * 3;
            //    Console.WriteLine(tripleTheSum);
            //}
            //else
            //{
            //    var sum  = firstNumber + secondNumber;
            //    Console.WriteLine(sum);
            //}
            #endregion

            //Exercise : Get the absolute value
            #region
            //Console.WriteLine("Please enter the first number: ");
            //var firstNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the second number: ");
            //var secondNumber = Convert.ToInt32(Console.ReadLine());

            //var difference = firstNumber - secondNumber;

            //if (firstNumber > secondNumber)
            //{
            //    Console.WriteLine((difference * -1) * 2);
            //}

            //if (difference < 0 )
            //{
            //    difference = difference * -1;
            //    Console.WriteLine(difference);
            //}
            #endregion
            #endregion

            //INTERFACES
            #region
            //Interface - it is a LANGUAGE CONSTRUCT that is similar to a class (in terms of syntax) but 
            //FUNDAMENTALLY DIFFERENT. We use Interfaces TO BUILD LOOSELY-COUPLED APPLICATIONS.

            //NOTE: ALL INTERFACES STARTS WITH LETTER "I" and Interface Members DO NOT HAVE ACCESS MODIFIERS.

            //Syntax on how to declare an Interface
            //public interface ITaxCalculator
            //{
            //      int Calculate();
            //}

            ////Example on how Interfaces IMPROVES the testability of the application
            ////Using the InterfaceOrderProcessor,InterfaceShipment,InterfaceOrder and InterfaceShippingCalculator
            //InterfaceOrderProcessor orderProcessor = new InterfaceOrderProcessor(new InterfaceShippingCalculator());
            //InterfaceOrder order = new InterfaceOrder { DatePlaced = DateTime.Now, TotalPrice = 100f };
            //orderProcessor.Process(order);
            #endregion

            //INTERFACES AND EXTENSIBILITY
            #region
            //CASE : We would like to create a tool for migrating a database.
            //Using this Classes for this example: DbMigrator,ConsoleLogger (the class that will implement the
            //Interface ILogger) and DbMigrator where we Injected the ILogger Interface as the dependency, this
            //technique is called DEPENDENCY INJECTION.
            //Now we will create an instance of DbMigrator and on the constructor we need to SPECIFY A CONCRETE
            //IMPLEMENTATION OF THAT ILogger INTERFACEA and we will get that (the object instantiation) to the 
            //CLASS WHO IMPLEMENTED THE ILogger INTERFACE
            //var dbMigrator = new DbMigrator(new ConsoleLogger());
            //var dbMigrator = new DbMigrator(new ConsoleLogger(), new InterfaceShippingCalculator());
            //dbMigrator.Migrate();

            //Just tried to add another Interface here for my better understanding
            //var order = new InterfaceOrder { DatePlaced = DateTime.Now, TotalPrice = 200f };
            //var totalCost = dbMigrator.Compute(order);
            //Console.WriteLine("This is the total cost: {0}",totalCost);


            //Now we decided that instead we Log them in the console we Log them on a FILE.
            //And to do that, we only need to Create a class called FileLogger and IMPLEMENT the ILogger Interface
            //We change the behavior of the application by CHANGING THE CONCRETE CLASS INSIDE THE DbMigrator Constructor.
            //We will now log those date INTO A FILE.
            //var dbMigrator = new DbMigrator(new FileLogger("C:\\Program Files\\log.txt"));
            //dbMigrator.Migrate();
            //We changed the behavior of the code by IMPLEMENTING AN INTERFACE, we DID NOT CHANGE ANY PIECE
            //OF CODE INSIDE THE DbMigrator Class. IN OOP this principle as OPEN CLOSED PRINCIPLE (OCP). W/c
            //states the Software Entities SHOULD BE OPEN FOR EXTENSION BUT CLOSED FOR MODIFICATION.

            #endregion

            //EXERCISE FOR MY SELF, REPLICATE DbMigrator and ILogger Implementation
            #region
            ////This time I will use the classes ReplicatedDbMigrator, IReplicatedLogger, ReplicatedConsoleLogger
            //var replicatedDbMigrator = new ReplicatedDbMigrator(new ReplicatedConsoleLogger());
            //replicatedDbMigrator.Migrate();
            #endregion

            //INTERFACE EXERCISE : Design a Workflow Engine
            #region
            //Workflow is the one who Implemented the Interface here
            //var workFlowEngine = new WorkFlowEngine(new Workflow());
            //workFlowEngine.Run();

            //SecondImplementationWorkflow is the one who Implemented the Interface here
            //var workFlowEngine = new WorkFlowEngine(new SecondImplementationWorkflow());
            //workFlowEngine.Run();

            //Workflow workflow = new Workflow();
            //workflow.Add(new SendEmail());
            //workflow.Add(new EditVideo());
            //workflow.Add(new UploadVideo());
            //WorkFlowEngine workFlowEngine = new WorkFlowEngine();
            //workFlowEngine.Run(workflow);
            #endregion

            //EXERCISE FOR MY SELF : Implement the correct way how Mosh did it on the Interfaces Exercise
            #region
            //For this exercise, we are going to use ExerciseForMySelfWorkFlowEngine Class
            //var workflow = new ReplicatedWorkflow();
            //workflow.Add(new VideoStarted());
            //workflow.Add(new VideoEncoding());
            //workflow.Add(new ReplicatedUploadVideo());
            //workflow.Add(new ChangeVideoStatus());
            //var workflowEngine = new ExerciseForMySelfWorkFlowEngine();
            //workflowEngine.Run(workflow);
            #endregion

            //INTERFACES AND POLYMORPHISM
            #region
            //var encoder = new VideoEncoder();
            //encoder.RegisterNotificationChannel(new MailNotificationChannel);
            //encoder.RegisterNotificationChannel(new SmsNotificationChannel);
            //encoder.Encode(new Video());
            #endregion

            //EXERCISE FOR MY SELF (CLASSES): STOPWATCH
            #region
            //int useOfStartAndStop = 0;

            //var stopWatchBaseClass = new StopwatchClassExercise();
            //do
            //{
            //    Console.WriteLine("Start or Stop");

            //    string input = Console.ReadLine().ToLower();

            //    if (useOfStartAndStop == 0 && input == "stop")
            //    {
            //        throw new InvalidOperationException("You cannot stop the Stopwatch without starting it.");
            //    }

            //    if (input == "start")
            //    {
            //        stopWatchBaseClass.Start();
            //    }

            //    Console.WriteLine("Type 'Stop' if you want to stop the stopwatch");
            //    input = Console.ReadLine();

            //    if (input == "stop")
            //    {
            //        stopWatchBaseClass.Stop();
            //        useOfStartAndStop++;
            //    }
            //} while (useOfStartAndStop <= 6);
            #endregion

            //EXERCISE FOR MY SELF (CLASSES): STACKOVERFLOW POST
            #region
            //var posts = new StockOverflowPostClass
            //{
            //    title = "The Power of Positive Thinking",
            //    description = "This is a book that will help you to think positively.",
            //    dateCreated = DateTime.Now
            //};

            ////posts._create

            //posts.AddPost(posts);
            //posts.upVote();
            //posts.upVote();
            //posts.upVote();
            //posts.upVote();
            //posts.downVote();

            //Console.WriteLine(posts.currentVote);

            //foreach (var post in posts.GetPosts())
            //{
            //    Console.WriteLine("Title: {0}, Description: {1}, Date Created: {2}, Current Vote: {3}",
            //    post.title, post.description, post.dateCreated, post.currentVote);
            //}
            #endregion

            //EXERCISE FOR MY SELF (CLASSES): STACK
            #region
            //var stack = new StackBaseClassExercise();
            //for (int i = 1; i <= 6; i++)
            //{
            //    stack.Push(i);
            //}

            //int listCount = stack.GetList().Count();

            //for (int i = 0; i < listCount; i++)
            //{
            //    stack.Pop();
            //}

            //stack.Clear();
            #endregion

            //EXERCISE FOR MY SELF (CLASSES): DATABASE CONNECTION
            #region
            //var DbCommand = new DbCommandExercise(new SqlConnectionDerivedClass("This is the Connection String for SQL Connection"));
            //DbCommand.Execute();

            //DbCommand = new DbCommandExercise(new OrcacleConnectionDerivedClass("This is the Connection String for Oracle Connection"));
            //DbCommand.Execute();
            #endregion

            //EXERCISE FOR MY SELF (CLASSES): WORKFLOW ENGINE
            #region
            var workflow = new WorkflowBaseClass();
            workflow.AddActivity(new UploadVideoActivity());
            workflow.AddActivity(new SendEmailActivity());
            workflow.AddActivity(new ChangeStatusActivity());
            workflow.AddActivity(new CallWebServiceActivity());

            var engine = new WorkflowEngineClass();
            engine.Run(workflow);
            #endregion
        }
    }
}