for i in `find /home/database/ -name "*.sql" | sort --version-sort`; do mysql -uaspnetrestudemy -pdocker!123 rest_with_asp_net_udemy < $i; done;