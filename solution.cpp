```cpp
#include <iostream>
#include <unordered_map>
#include <string>

class URLShortener {
    std::unordered_map<std::string, std::string> urlMap;
    std::string domain = "http://short.url/";

public:
    std::string shorten(const std::string& url) {
        auto hash = std::hash<std::string>{}(url);
        std::string shortUrl = domain + std::to_string(hash);
        urlMap[shortUrl] = url;
        return shortUrl;
    }

    std::string restore(const std::string& shortUrl) {
        return urlMap[shortUrl];
    }
};

int main() {
    URLShortener urlShortener;
    std::string url = "http://verylongurl.com/path/to/resource";
    std::string shortUrl = urlShortener.shorten(url);
    std::cout << "Short URL: " << shortUrl << std::endl;
    std::cout << "Original URL: " << urlShortener.restore(shortUrl) << std::endl;
    return 0;
}
```