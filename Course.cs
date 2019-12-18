namespace csharp_course {
    class Course {
        public string pid;

        public int javaScore;

        public int cppScore;

        public int csharpScore;

        public Course(string pid, int javaScore, int cppScore, int csharpScore){
            this.cppScore = cppScore;
            this.pid = pid;
            this.javaScore = javaScore;
            this.csharpScore = csharpScore;
        }
    }
}