shortenURL(longUrl) {
        let shortUrl = this.baseUrl + this.generateShortCode();
        this.urlMap.set(shortUrl, longUrl);
        return shortUrl;
    }