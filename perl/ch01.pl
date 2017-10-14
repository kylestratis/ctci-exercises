#!/usr/bin/perl

use strict;
use warnings;

# Implement an algorithm to determine if string has all unique chars
# Inputs: str
sub question01 {
    my %args = @_;

    foreach my $arg (qq{str}) {
        if (!exists $args{$arg}) {
            return "Error!";
        }
    }

    my @char_array = split //, $args{str};
    my %found;
    return 0 if (scalar @char_array > 256); # Assume ASCII
    
    # Use hash here because tmk there's no equivalent 
    # charAt method to return codepoints for a character
    foreach my $char (@char_array) {
        $found{$char} += 1;
        if ($found{$char} > 1) {
            return 0;
        }
    }
    
    return 1;
}

my $result;
$result = question01(str => "test");
if ($result && $result ne "Error!") {
    print "Q1a Unique (incorrect)\n";
}
else {
    print "Q1a not unique (correct)\n";
}

$result = question01(str => "this");
if ($result && $result ne "Error!") {
    print "Q1b Unique (correct)\n";
}
else {
    print "Q1b not unique (incorrect)\n";
}
