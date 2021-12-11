### Repository

Mediates between the domain and data mapping layers, acting like an in-memory collection of domain objects.

- minimizes duplicate query logic

```
var courses = _repository.GetCourses();
```

- Decouples your application from persistence frameworks

###### Unit of Work

Maintains a list of objects affected by a business transaction and coordinates the writing out of changes

###### Entity Framework



