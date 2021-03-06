from django.conf.urls import patterns, include, url
from Scratchpad.views import hello, links, scratchpad

# Uncomment the next two lines to enable the admin:
# from django.contrib import admin
# admin.autodiscover()

urlpatterns = patterns('',
    # Examples:
    # url(r'^$', 'Scratchpad.views.home', name='home'),
    # url(r'^Scratchpad/', include('Scratchpad.foo.urls')),

    # Uncomment the admin/doc line below to enable admin documentation:
    # url(r'^admin/doc/', include('django.contrib.admindocs.urls')),

    # Uncomment the next line to enable the admin:
    # url(r'^admin/', include(admin.site.urls)),

    url(r'^hello/$', hello),
	url(r'^links/$', links),
    url(r'^scratchpad/$', scratchpad)
)
