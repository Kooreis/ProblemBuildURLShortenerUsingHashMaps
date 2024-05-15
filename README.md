# Question: How do you build a URL shortener system using hash maps? JavaScript Summary

The JavaScript code provided is a simple implementation of a URL shortener system using a hash map. The URLShortener class is created with a map to store the long URLs and their corresponding short URLs. The 'shortenURL' method is used to generate a short code and add the long URL to the map with the short URL as the key. This is done by concatenating a base URL with a randomly generated 5-character string, which is produced by the 'generateShortCode' method. This method selects random characters from a string of possible characters, which includes uppercase and lowercase letters and numbers. The 'getLongURL' method is used to retrieve the long URL using the short URL as the key. This way, the system can create a unique short URL for each long URL input, and also retrieve the original long URL when needed.

---

# TypeScript Differences

The TypeScript version of the solution is similar to the JavaScript version in terms of the overall logic and approach. Both versions use a Map to store the long URLs and their corresponding short URLs, and both have methods to shorten a URL and retrieve the original URL using the short URL.

However, there are a few differences:

1. TypeScript uses static typing: In the TypeScript version, the types of the variables and function return values are explicitly declared. For example, the `shorten` and `getOriginalUrl` methods are declared to take a string as an argument and return a string. This can help catch potential type-related errors at compile time.

2. Different random string generation: The TypeScript version uses `Math.random().toString(36).substring(2, 8)` to generate a random string, while the JavaScript version uses a loop and `Math.random()` to generate a random string from a predefined set of characters.

3. Error handling: The TypeScript version includes a default return value of 'URL not found!' in the `getOriginalUrl` method if the short URL does not exist in the map. The JavaScript version does not have this feature.

4. String interpolation: The TypeScript version uses string interpolation (`${}`) to construct the short URL and console log messages, while the JavaScript version uses string concatenation.

5. Private keyword: The TypeScript version uses the `private` keyword to make the `urls` Map private to the `UrlShortener` class. This means it can't be accessed directly from outside the class. The JavaScript version does not have this feature because JavaScript does not have built-in support for private properties (until ES2020).

---

# C++ Differences

The C++ version of the URL shortener also uses a hash map (in this case, an unordered_map) to store the long URLs and their corresponding short URLs. However, instead of generating a random 5-character string for the short URL, it uses the hash of the long URL. This is done using the `std::hash` function, which is a built-in function in C++ for generating hash values of various types. The hash is then converted to a string using `std::to_string` and appended to the base URL to form the short URL.

The `shorten` method in the C++ version is equivalent to the `shortenURL` method in the JavaScript version, and the `restore` method is equivalent to the `getLongURL` method. The main difference is in how the short URL is generated.

In terms of language features, the C++ version uses features such as templates (for the `std::unordered_map` and `std::hash`), and the `auto` keyword for type inference. The JavaScript version uses features such as the `Map` object, the `let` keyword for block-scoped variables, and string concatenation with the `+` operator.

The C++ version also includes a `main` function, which is the entry point of the program. This is a feature of C++ and many other compiled languages, but is not present in the JavaScript version, which is typically run in a browser or Node.js environment.

---
