using GraphQL.Sandbox.WebApi.Entities;
using GraphQL.Types;

namespace GraphQL.Sandbox.WebApi.GraphQL.Types
{
    public class StudentType : ObjectGraphType<Student>
    {
        public StudentType()
        {
            Field(t => t.StudentID);

            Field(t => t.StudentName);
        }
    }
}
