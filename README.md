#### Take Home Task
We’d like you to provide solutions for the scenarios listed below. These have been prioritized into **Must**, **Should**, and **Could** categories.

Please spend no more than 2 hours on this exercise. The goal is to see how you interpret the requirements and design a solution that focuses on business logic.  
The MVP for this task is to complete the **Must** category — the others are optional.

Ideally your code used will be clean, solid and scalable.

We’ve attached a `.zip` file containing a `.sln` (solution) file. When you’re finished, either:
- Upload your solution to a public GitHub repository and share the link, or
- Create a pull request into this one, or
- Zip your solution (excluding `bin` folder) and send it back via email.

The solution provided is basic, it contains a repository with data in it and some data entities. You can change anything to suit your style of coding, e.g. moving files, creating projects, it's completely up to you. 

The scenario solutions can be API endpoints or whatever else you prefer, what's important is seeing the code and how you think it should be structured.

#### Scenarios
**Must**
- Given a search term, get a list of products which match the search term.
	- Think about what this search term might include if you were building a production app.
- Given a create product request, add it to the "database" using the repository.
	- The data is hardcoded so this won't actually add anything, we're more interested on how you'd approach the feature.
	- How would you stop malformed data?
- Given a collection of CategoryIds, get the appropriate Categories and Products.
	- Ideally the result would be each category with a list of products beneath it.

**Should**
- How can we enforce any future changes from other developers won't break the API?
- How can we structure the solution so that changing the database or API/interface won't effect our business rules?

**Could**
- How quickly can we whip up a UI which can call these endpoints? Perhaps we could a JavaScript framework or Blazor.
