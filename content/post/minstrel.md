+++
date = "2016-04-07T18:02:58+01:00"
draft = false
tags = [ "wifi", "bufferbloat", "papers" ]
title = "On the Minstrel Wifi Rate Controller"
description = "Wireless rate selection is *hard* and deeply misunderstood..."
+++

Andrew Mcgregor and Derek Smithies' ["Rate Adaptation for 802.11 Wireless Networks: Minstrel"](/papers/minstrel-sigcomm-final.pdf) is the key, [fundamental paper on the Minstrel wifi rate control](/papers/minstrel-sigcomm-final.pdf) algorithm. I don't know how many hundreds of millions of machines Minstrel is deployed on today, but the paper itself describing the algorithm, *never got past academic review*, perhaps because the opening sentence contained the word *"practical"*.  Even if this paper had been published, and had been deeply understood, very few today seem to understand the problems Minstrel addressed, how those problems have morphed over time, and how new problems have arisen. I will try to get into those in detail in the coming weeks, but briefly:

Most research into wifi rate control has died, in part due to
inaccessabilty of the basic statistics about wifi transmit rates from
most proprietary firmwares.

The Minstrel related algorithms ([minstrel-ht](https://lwn.net/Articles/376765/) and [minstrel-blues](https://github.com/thuehn/Minstrel-Blues)) have seen continuous tweaks for each new wifi technology (it
pre-dates 802.11n), without rigorous widescale testing or analysis.

The paper (which has long circulated as "samizdat") fills in many missing blanks as to how to do wifi rate control better, that, so far, I haven't seen in the literature, even a decade after "non-publication".

Minstrel's development pre-dates 802.11n aggregates, it pre-dates the aggressive retries used in many (most) wifi devices, it pre-dates massive improvements
in DSP technologies, pre-dates MIMO, and it predates wifi achieving a dynamic range of bandwidths of 1Mbit to over a gigabit. It also completely ignores the congestion
control problem and pre-dates the advances in queue theory led by [codel](/post/codel_on_wifi). Lastly, it has long been in dire need of an update to match modern conditions with massive numbers of clients and interfering access points.

Still, it's the best darn paper and starting point, on how one wifi rate controller works I've ever read.  Go read it. I'll wait... (There are several papers it references that are good, too!)

My main observation from rereading the paper now is that wifi rate control sometimes needs
to aim for a higher rate and/or less retries to achieve the "right" amount of packet loss, not the "best" rate with no packet loss. By an [upper layer signalling minstrel](/post/selective_unprotect) to do that, when needed, we'd be much better off.

Here are a [few](https://wireless.wiki.kernel.org/en/developers/documentation/mac80211/ratecontrol/minstrel) [other](https://internetnz.nz/sites/default/files/icc_13_final_0.pdf) good references on minstrel.

My thanks to Andrew Mcgregor for patiently schooling me on the inner details of the algorithm over the years!
