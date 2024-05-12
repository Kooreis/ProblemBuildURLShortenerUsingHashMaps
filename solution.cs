Here is a simple implementation of a URL shortener using JavaScript:

```javascript
class URLShortener {
    constructor() {
        this.urlMap = new Map();
        this.baseUrl = "http://short.url/";
    }

    shortenURL(longUrl) {
        let shortUrl = this.baseUrl + this.generateShortCode();
        this.urlMap.set(shortUrl, longUrl);
        return shortUrl;
    }

    getLongURL(shortUrl) {
        return this.urlMap.get(shortUrl);
    }

    generateShortCode() {
        let text = "";
        let possible = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        for (let i = 0; i < 5; i++)
            text += possible.charAt(Math.floor(Math.random() * possible.length));

        return text;
    }
}

let urlShortener = new URLShortener();
let shortUrl = urlShortener.shortenURL("https://www.longurl.com/some/long/url");
console.log(shortUrl);
console.log(urlShortener.getLongURL(shortUrl));
```

This code creates a URLShortener class with a map to store the long URLs and their corresponding short URLs. The `shortenURL` method generates a short code and adds the long URL to the map with the short URL as the key. The `getLongURL` method retrieves the long URL using the short URL. The `generateShortCode` method generates a random 5-character string to be used in the short URL.