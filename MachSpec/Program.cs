/*

  Usage of Machine.Specifications (Because, It, etc)

dotnet add package Machine.Specifications
dotnet add package Microsoft.NET.Test.SDK
dotnet add package Machine.Specifications.Runner.VisualStudio
dotnet test
*/
using Machine.Specifications;

[Subject("Authentication")]
class When_authenticating_an_admin_user
{
    static string[]? grades;
    static IEnumerable<string>? topThreeGrades;

    Establish context = () => grades = new string[] { "a", "", "", "", "", "", "z" };

    Because of = () => topThreeGrades = grades.OrderBy(grade => grade).Take(3);

    // It should_indicate_the_users_role = () => string.Join(string.Empty, topThreeGrades.ToArray()).ShouldEqual(string.Empty); 
    It should_indicate_the_users_role = () => new ArraySegment<string>(grades, 1, 5);
}