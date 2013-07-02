from django.http import HttpResponse

def hello(request):
	return HttpResponse("Hello, Jay!!!")

def links(request):
	return HttpResponse("<a>http://google.com</a>")