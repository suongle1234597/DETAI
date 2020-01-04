ALTER VIEW [dbo].[V_DSPM]
AS
SELECT TENCS=PUBS.description, TENSERVER= subscriber_server
FROM dbo.sysmergepublications PUBS, dbo.sysmergesubscriptions SUBS
WHERE PUBS.pubid= SUBS.PUBID AND PUBS.publisher <>
SUBS.subscriber_server
EXCEPT
SELECT TENCS=PUBS.description, TENSERVER= subscriber_server
FROM dbo.sysmergepublications PUBS, dbo.sysmergesubscriptions SUBS
WHERE PUBS.pubid= SUBS.PUBID AND PUBS.publisher <>
SUBS.subscriber_server AND SUBS.subscriber_server='SUONG\SERVER3'
