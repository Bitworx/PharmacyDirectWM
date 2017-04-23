Public Class ManifestCounters

    Private manifestLoaded As Integer = 0
    Private manifestDelivered As Integer = 0
    Private manifestToUpload As Integer = 0

    Property LoadedManifests() As Integer
        Get
            Return manifestLoaded
        End Get
        Set(ByVal value As Integer)
            manifestLoaded = value
        End Set
    End Property

    Property DeliveredManifests()
        Get
            Return manifestDelivered
        End Get
        Set(ByVal value)
            manifestDelivered = value
        End Set
    End Property

    Property UploadManifest()
        Get
            Return manifestToUpload
        End Get
        Set(ByVal value)
            manifestToUpload = value
        End Set
    End Property

    Sub New()
        manifestLoaded = 0
        'Check in local db for loaded Manifests

        'Check in local db for manifests to upload to web

        'Check in local db for manifests delivered

    End Sub
End Class
