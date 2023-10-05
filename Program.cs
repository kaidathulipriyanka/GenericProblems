namespace GenericsPracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeleteEleFromArray deleteEleFromArray = new DeleteEleFromArray();
            deleteEleFromArray.Delete_Ele_FromArray();

            DeleteELeFromArrayUseGenMethod deleteELeFromArrayUseGenMethod = new DeleteELeFromArrayUseGenMethod();
            deleteELeFromArrayUseGenMethod.DeleteELeFromArray_UseGenMethod();

            Generic_Class_Concept generic_Class_Concept = new Generic_Class_Concept();
            generic_Class_Concept.Generic_class();

            findMinInteger findMinInteger = new findMinInteger();   
            findMinInteger.find_Min_Integer();

            FindMinfloat findMinfloat = new FindMinfloat(); 
            findMinfloat.Find_Min_float();

            findMinstring findstring =new findMinstring();
            findstring.Find_Min_String();

            RefactorAndExtendsAll refactorAndExtendsAll = new RefactorAndExtendsAll();  
            refactorAndExtendsAll.Refactor_And_ExtendsAll();

            RefactorGenericClassAll refactorGenericClassAll = new RefactorGenericClassAll();
            refactorAndExtendsAll .Refactor_And_ExtendsAll();








        }
    }
}