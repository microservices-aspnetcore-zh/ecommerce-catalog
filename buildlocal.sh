rm -rf .wercker
wercker build --git-domain github.com --git-owner microservices-aspnetcore --git-repository ecommerce-catalog
rm -rf .wercker