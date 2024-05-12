Here is a simple console application in TypeScript that demonstrates a basic URL shortener system using hash maps:

```typescript
class UrlShortener {
    private urls = new Map<string, string>();

    shorten(url: string): string {
        let randomString = Math.random().toString(36).substring(2, 8);
        this.urls.set(randomString, url);
        return `http://short.url/${randomString}`;
    }

    getOriginalUrl(shortUrl: string): string {
        let key = shortUrl.replace('http://short.url/', '');
        return this.urls.get(key) || 'URL not found!';
    }
}

let urlShortener = new UrlShortener();
let shortUrl = urlShortener.shorten('http://longurl.com/page/subpage');
console.log(`Short URL: ${shortUrl}`);
console.log(`Original URL: ${urlShortener.getOriginalUrl(shortUrl)}`);
```

This code defines a `UrlShortener` class that uses a `Map` to store shortened URLs. The `shorten` method generates a random string and uses it as a key to store the original URL. The `getOriginalUrl` method retrieves the original URL using the short URL. The console application then creates an instance of `UrlShortener`, shortens a URL, and retrieves the original URL.