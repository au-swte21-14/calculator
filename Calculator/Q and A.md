* How are you going to test the different operations?
    * Which different tests do you need for each operation?

      You need to make sure, that each operation can calculate at least 1 number correctly, but you would probably need
      to test both negative and positive inputs and results, but also fractions.
    * What are the expected outputs of the tests?
    
      That they complete correctly.
    * How are you going to run the tests so that you can check that each test passes, i.e. that the output of the
      operation under test is as expected?

      You could throw an exception on failure, or write a summary at exit.
* How well does your test method scale?
    * If you introduce many more tests or many more operations in Calculator, is your test method still practically
      usable?

      No, it would require a lot of boilerplate code, to keep track of an overall test result.
* What could make your life easier?
    * Considering the above (especially 2.), what could make your life easier? What would you require of a tool to help
      you?

      A tool that handles all boilerplate code, and hides the test implementation.