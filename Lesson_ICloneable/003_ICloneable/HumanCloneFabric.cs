namespace _003_ICloneable
{
    internal static class HumanCloneFabric
    {
        internal static Human CloneHuman(Human originalHuman)
        {
            Human clonedHuman = new Human();
            clonedHuman.Name = originalHuman.Name;
            clonedHuman.Age = originalHuman.Age;
            clonedHuman.Birthplace = originalHuman.Birthplace;
            clonedHuman.Skills = originalHuman.Skills;
            return clonedHuman;
        }

        internal static Human DeepCloneHuman(Human originalHuman)
        {
            Human clonedHuman = new Human
            {
                Name = originalHuman.Name,
                Age = originalHuman.Age,
                Birthplace = new Birthplace(originalHuman?.Birthplace?.City, originalHuman?.Birthplace?.Country),
                Skills = new List<Skill>(originalHuman.Skills)
            };
            return clonedHuman;
        }
    }
}
