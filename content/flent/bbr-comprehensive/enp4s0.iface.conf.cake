# Uplink and Downlink values are in kbps
#UPLINK=110000
#DOWNLINK=10000
UPLINK=20000
DOWNLINK=$UPLINK

# SQM recipe to use. For more information, see /usr/lib/sqm/*.help
SCRIPT=piece_of_cake.qos
#SCRIPT=simplest.qos

# Optional/advanced config

ENABLED=1
#QDISC=fq_codel
QDISC=cake

#LLAM=tc_stab
#LINKLAYER=none
#OVERHEAD=0
#STAB_MTU=2047
#STAB_TSIZE=512
#STAB_MPU=0

ILIMIT=10000
ELIMIT=10000
ITARGET=5ms
ETARGET=5ms

# ECN ingress resp. egress. Values are ECN or NOECN.
IECN=ECN
EECN=ECN

# Extra qdisc options ingress resp. egress
#IQDISC_OPTS="flowblind"
#EQDISC_OPTS="flowblind"

# CoDel target
TARGET=5ms

#SQUASH_DSCP=1
#SQUASH_INGRESS=1

