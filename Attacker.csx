           //scriptcs c:\warmachine.csx
            int maxLoops = 16192;
            string urlBase = "http://basmaster.cloudapp.net/";

            var urls = new List<string>();
            var urlEnd = "&machine=" + Environment.MachineName;
            for (int i = 0; i < maxLoops; i++)
            {
//                urls.Add(urlBase + "DSCF4107.JPG?V1&" + i + urlEnd);
//                urls.Add(urlBase + "SimpleLoad/UserAccountPicture.jpg?R1&" + i + urlEnd);
                urls.Add(urlBase + "?" + i + urlEnd);
//                urls.Add(urlBase + "DSCF4107.JPG?V2&" + i + urlEnd);
                urls.Add(urlBase + "foo.html?" + i + urlEnd);
//                urls.Add(urlBase + "DSCF4107.JPG?V3&" + i + urlEnd);
                urls.Add(urlBase + "foo/bar/" + i + urlEnd);
//                urls.Add(urlBase + "DSCF4107.JPG?V4&" + i + urlEnd);
                urls.Add(urlBase + "SimpleLoad/default.aspx?numdigits=6000&i=" + i + urlEnd);
                urls.Add(urlBase + "SimpleLoad/default.aspx?numdigits=6000&i=" + i + urlEnd);
                urls.Add(urlBase + "SimpleLoad/default.aspx?numdigits=6000&i=" + i + urlEnd);
                urls.Add(urlBase + "SimpleLoad/default.aspx?numdigits=6000&i=" + i + urlEnd);
//                urls.Add(urlBase + "DSCF4107.JPG?V5&" + i + urlEnd);
//                urls.Add(urlBase + "SimpleLoad/UserAccountPicture.jpg?R2&" + i + urlEnd);
//               urls.Add(urlBase + "DSCF4107.JPG?V6&" + i + urlEnd);
//                urls.Add(urlBase + "SimpleLoad/UserAccountPicture.jpg?R3&" + i + urlEnd);
//                urls.Add(urlBase + "DSCF4107.JPG?V7&" + i + urlEnd);
            }

            var po = new ParallelOptions();
            po.MaxDegreeOfParallelism = 8096;
            var urlCount = urls.Count;
            int reqnum = 0;
            int pendingRequestCount = 0;

            Parallel.ForEach(urls, po, url =>
            {
                ++pendingRequestCount;
                try
                {
                    using (var client = new System.Net.WebClient())
                    {
                        var html = client.DownloadString(url);
                        Console.WriteLine("Completed request {0} of {1} at {2}. {3} pending.\n ->Url: {4}",
                            reqnum + 1, urlCount, DateTime.Now.ToLongTimeString(), pendingRequestCount, url);
                    }
                }
                catch { }
                finally { --pendingRequestCount; ++reqnum; }

            });